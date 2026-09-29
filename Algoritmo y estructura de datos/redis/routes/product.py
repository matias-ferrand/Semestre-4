from fastapi import APIRouter
from models import product
from services.redis_service import delete_hash, get_hash, save_hash
from models.product import Product

routes_product = APIRouter()
fake_db = []
@routes_product.post("/create", response_model=Product)
def create(product: Product):
 try:
     product_dict = product.dict()
     fake_db.append(product_dict)
     save_hash(key=product_dict["id"], data=product_dict)
     return product
 except Exception as e:
     return e
@routes_product.get("/get/{id}")
def get(id: str):
 try:
    data = get_hash(key=id)
    if len(data) == 0:
        product = list(filter(lambda field: field["id"] == id, fake_db))[0]
        save_hash(key=id, data=product)
        return product
    return data
 except Exception as e:
     return e
@routes_product.delete("/delete/{id}")
def delete(id: str):
    try:
        keys = Product.__fields__.keys()
        delete_hash(key=id, keys=keys)
        product = list(filter(lambda field: field["id"] != id, fake_db))
        if len(product) != 0:
            fake_db.remove(product)
            return {
                "message": "success"
            }
    
    except Exception as e:
        return e