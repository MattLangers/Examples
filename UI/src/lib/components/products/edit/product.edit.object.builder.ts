import type { Product } from "$lib/models/product"
import type { Product_Edit } from "$lib/models/product.edit";

export interface IProductEditObjectBuilder{
    create(originalProduct: Product, newProduct: Product_Edit): Product_Edit
}

export class Product_Edit_Object_Builder implements IProductEditObjectBuilder{
    public create(originalProduct: Product, newProduct: Product): Product_Edit {
        
        const result: Product_Edit = {};

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