<script lang="ts">
	import type { ProductType } from '$lib/models/productType';
	import { productTypes as storeProductTypes } from '$lib/components/products/product.type.store';
		
	let productTypes: ProductType[] = [];

	storeProductTypes.subscribe((productTypeValues) => {
		productTypes = productTypeValues;
	});

	export let productTypeSelected: ProductType = productTypes[0];
</script>

<select
	bind:value={productTypeSelected}
	id="product-type"
	name="product-type"
	autocomplete="product-type"
	class="block w-full rounded-md border border-gray-300 bg-white py-2 px-3 p-2 shadow-sm focus:border-grey-600 focus:outline-none focus:ring-indigo-500 sm:text-sm"
>
	{#each productTypes as productType}
		<option value="{productType}">{productType.name}</option>
	{/each}
</select>
