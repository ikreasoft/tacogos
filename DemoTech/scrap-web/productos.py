import requests
from bs4 import BeautifulSoup

# URL de la página web a scrapear
url = "https://ikreasoft.github.io/tacogos/sitetacogos/menu.html"

# Realizar la solicitud HTTP y obtener el contenido HTML
response = requests.get(url)
html_content = response.content

# Crear un objeto BeautifulSoup a partir del HTML
soup = BeautifulSoup(html_content, "html.parser")

# Identificar los elementos que contienen información de los productos
productos = soup.find_all("div", class_="event-item-modern")

# Extraer y procesar la información de cada producto
for producto in productos:
    # Nombre del producto
    nombre = producto.find("h4", class_="event-item-modern-title").text.strip()

    # Precio del producto
    precio = producto.find("p", class_="event-time").text.strip()

    # Descripción del producto
    descripcion = producto.find("div", class_="event-item-modern-text").text.strip()

    # Imagen del producto (si existe)
    imagen = producto.find("img")
    if imagen:
        imagen_url = imagen["src"]
    else:
        imagen_url = None

    # Imprimir la información del producto
    print(f"Producto: {nombre}")
    print(f"Precio: {precio}")
    print(f"Descripción: {descripcion}")
    if imagen_url:
        print(f"Imagen: {imagen_url}")
    print("-------------------------")
