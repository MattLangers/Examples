import type { ProductType } from '$lib/models/productType';
import { writable } from 'svelte/store';

export const productTypes = writable<ProductType[]>([]);