<script lang="ts">
	import ProdcuctTypeSelectElement from '$lib/components/products/product.type.select.element.svelte';
	import type { ProductType } from '$lib/models/productType';
	import { variables } from '../../../variables';
	import { productTypes as storeProductTypes } from '$lib/components/products/product.type.store';

	let productTypeSelected: ProductType;
	let product_name = '';
	let creatingProduct = false;
    let productTypes: ProductType[] = [];

	storeProductTypes.subscribe((productTypeValues) => {
		productTypes = productTypeValues;
	});

	async function handleSubmit() {
		if (product_name.length > 0 && productTypeSelected.id > 0) {
			creatingProduct = true;
			var result = await createProduct(product_name, productTypeSelected.id);
			creatingProduct = false;
			if (result) {
				CompletedCreationRequest();
			}
		}
	}

	function CompletedCreationRequest() {
		product_name = '';
        productTypeSelected = productTypes[0];
	}

	var createProduct = async function (name: string, productTypeId: number): Promise<boolean> {
		const response = await fetch(variables.api_URL + 'products', {
			method: 'POST',
			headers: {
				'Content-Type': 'application/json'
			},
			body: JSON.stringify({ Name: name, ProductTypeId: productTypeId })
		});

		var result = await response.json();
		return response.ok;
	};
</script>

<div class="flex flex-wrap pl-5 pt-5 items-center">
	<div class="">
		<input
			bind:value={product_name}
			type="text"
			id="name"
			class="bg-gray-50 
                        border border-gray-300 
                        text-gray-900 
                        text-sm 
                        rounded-lg 
                        focus:ring-blue-500 
                        focus:border-blue-500 
                        p-2.5 
                        dark:bg-white-700 
                        dark:border-gray-300 
                        dark:placeholder-gray-400 
                        dark:text-gray 
                        dark:focus:ring-blue-500 
                        dark:focus:border-blue-500"
			placeholder="Product name"
			autocomplete="product-name"
		/>
	</div>
	<div class="ml-2">
		<ProdcuctTypeSelectElement bind:productTypeSelected />
	</div>
	<div class="ml-2">
		{#if creatingProduct}
			<button
				type="button"
				class="inline-flex items-center px-4 py-2 font-semibold leading-6 text-sm shadow rounded-md text-white bg-indigo-500 hover:bg-indigo-400 transition ease-in-out duration-150 cursor-not-allowed ml-5"
				disabled
			>
				<svg
					class="animate-spin -ml-1 mr-3 h-5 w-5 text-white"
					xmlns="http://www.w3.org/2000/svg"
					fill="none"
					viewBox="0 0 24 24"
				>
					<circle
						class="opacity-25"
						cx="12"
						cy="12"
						r="10"
						stroke="currentColor"
						stroke-width="4"
					/>
					<path
						class="opacity-75"
						fill="currentColor"
						d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
					/>
				</svg>
				Processing...
			</button>
		{:else}
			<button
				type="submit"
				class="inline-flex items-center px-4 py-2 font-semibold leading-6 text-sm shadow rounded-md text-white bg-indigo-500 hover:bg-indigo-400 transition ease-in-out duration-150 ml-5"
				on:click={handleSubmit}>Create</button
			>
		{/if}
	</div>
</div>
