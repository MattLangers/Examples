import type { Product } from '$lib/models/product';
import { writable } from 'svelte/store';

export const products = writable<Product[]>([]);