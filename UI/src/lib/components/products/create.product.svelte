<script lang="ts">
	import type { ProductType } from '$lib/models/productType';
	import { productTypes as storeProductTypes } from '$lib/components/products/product.type.store';

	let product_name = '';
	let productTypes: ProductType[] = [];

	storeProductTypes.subscribe((productTypeValues) => {
		productTypes = productTypeValues;
	});
</script>

<div class="grid grid-cols-4 pl-5 pt-5 items-center">
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
                    pl-10 p-2.5 
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
	<div>
		<select
			id="product-type"
			name="product-type"
			autocomplete="product-type"
			class="mt-1 block w-full rounded-md border border-gray-300 bg-white py-2 px-3 shadow-sm focus:border-grey-600 focus:outline-none focus:ring-indigo-500 sm:text-sm"
		>
			{#each productTypes as productType}
				<option>{productType.name}</option>
			{/each}
		</select>
	</div>
	<div>
		<button
			type="submit"
			class="inline-flex justify-center rounded-md border border-transparent bg-indigo-600 py-2 px-4 text-sm font-medium text-white shadow-sm hover:bg-indigo-700 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2 ml-5"
			>Create</button
		>
	</div>
</div>
