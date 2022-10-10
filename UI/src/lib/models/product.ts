import type { ProductType } from "./productType"

export type Product = {
	id: string
	description: string
	name: string
	price: number
	ranking: number
    productType: ProductType
}