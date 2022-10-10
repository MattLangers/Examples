import type { Product } from "$lib/models/product"
import type { ProductEdit } from "$lib/models/product.edit";

export interface IProductEditObjectBuilder{
    create(originalProduct: Product, newProduct: ProductEdit): ProductEdit
}

export class ProductEditObjectBuilder implements IProductEditObjectBuilder{
    public create(originalProduct: Product, newProduct: Product): ProductEdit {
        
        const result: ProductEdit = {};

        if(originalProduct.name !== newProduct.name && newProduct.name.length > 0){
            result.name = newProduct.name
        }

        if(originalProduct.description !== newProduct.description && newProduct.description.length > 0){
            result.description = newProduct.description
        }

        if(originalProduct.ranking !== newProduct.ranking){
            result.ranking = newProduct.ranking
        }

        if(originalProduct.price !== newProduct.price){
            result.price = newProduct.price
        }

        return result;
    }      
}