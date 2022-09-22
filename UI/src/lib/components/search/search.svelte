<script lang="ts">
	import type { ProductType } from '$lib/models/productType';
	import type { Product } from '$lib/models/product';
	import { variables } from '../../../variables';
	import type { QueryStringParams } from '$lib/models/query.string.params';
	import { onMount } from 'svelte';
	import { productTypes as storeProductTypes } from "$lib/components/products/product.type.store"
	import ProdcuctTypeSelectElement from '$lib/components/products/product.type.select.element.svelte';

	export let products: Product[] = [];
    export let searchProductsCompleted = false;

	let searchText = '';
	let productTypeSelected: ProductType;
	let productTypes: ProductType[] = [];

	storeProductTypes.subscribe((productTypeValues) => {
		productTypes = productTypeValues;
	});

	var getProductTypes = async function (): Promise<void> {
		searchProductsCompleted = false;
        const response = await fetch(variables.api_URL + 'product-types');
		const data = await response.json().then(data => data as ProductType[]);
		data.unshift({name: "Please select", id: 0})
		storeProductTypes.update((v) => v = <never[]>data);
        searchProductsCompleted = true;
		productTypeSelected = productTypes[0];
	};

	var getProducts = async function (productType?: ProductType, searchText?: string): Promise<void> {
		const querystringParameters: QueryStringParams = {};

		if (searchText !== undefined) {
			querystringParameters.name = searchText;
		}

		if (productType !== undefined && productType.id !== undefined) {
			querystringParameters['product-type'] = productType.id.toString();
		}

		let url =
			variables.api_URL + 'products?' + new URLSearchParams(querystringParameters).toString();

		const response = await fetch(url);
		products = await response.json();
	};

	onMount(() => {
		getProducts(), getProductTypes();
	});
</script>

<label for="simple-search" class="sr-only">Search</label>
<div class="relative w-full mr-2">
	<div class="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none">
		<svg
			aria-hidden="true"
			class="w-5 h-5 text-gray-500 dark:text-gray-400"
			fill="currentColor"
			viewBox="0 0 20 20"
			xmlns="http://www.w3.org/2000/svg"
			><path
				fill-rule="evenodd"
				d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z"
				clip-rule="evenodd"
			/></svg
		>
	</div>
	<input
		bind:value={searchText}
		type="text"
		id="search-box"
		class="bg-gray-50 
                    border border-gray-300 
                    text-gray-900 
                    text-sm 
                    rounded-lg 
                    focus:ring-blue-500 
                    focus:border-blue-500 
                    block w-full 
                    pl-10 p-2 
                    dark:bg-white-700 
                    dark:border-gray-300 
                    dark:placeholder-gray-400 
                    dark:text-gray 
                    dark:focus:ring-blue-500 
                    dark:focus:border-blue-500"
		placeholder="Search"
		required
	/>
</div>
<ProdcuctTypeSelectElement bind:productTypeSelected />
<button
	type="submit"
	on:click={() => {
		getProducts(productTypeSelected, searchText);
	}}
	class="p-2.5 ml-2 
                            text-sm font-medium 
                            text-white bg-gray-700 
                            rounded-lg border 
                            border-gray-700 
                            hover:bg-gray-800 
                            focus:ring-4 
                            focus:outline-none 
                            focus:ring-gray-300 
                            dark:bg-gray-500 
                            dark:hover:bg-gray-600 
                            dark:focus:ring-gray-700"
>
	<svg
		class="w-5 h-5"
		fill="none"
		stroke="currentColor"
		viewBox="0 0 24 24"
		xmlns="http://www.w3.org/2000/svg"
		><path
			stroke-linecap="round"
			stroke-linejoin="round"
			stroke-width="2"
			d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"
		/></svg
	>
	<span class="sr-only">Search</span>
</button>
<span id="product-count" class="pl-2.5 hide_on_small_screens fade_out_search_area"
	>{products.length}</span
>