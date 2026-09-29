from fastapi import FastAPI
from routes.product import routes_product

app = FastAPI()
@app.get("/")
def root():
    return {"message": "Hello World!"}

app.include_router(routes_product, prefix="/products")

if __name__ == "__main__":
    import uvicorn
    uvicorn.run("main:app", host="127.0.0.1", port=8000, reload=True)