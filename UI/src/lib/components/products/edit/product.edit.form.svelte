<script lang="ts">
	import Edit_Price from './create.edit.price.svelte';
	import Edit_Product_Ranking from '../ranking/create.edit.product.ranking.svelte';

	export let product_name: string;
	export let product_description: string;
	export let product_price: number;
	export let product_ranking: number;
</script>

<div class="form-group mb-6">
	<input
		type="text"
		class="form-control
										  block
										  w-full
										  px-3
										  py-1.5
										  text-base
										  font-normal
										  text-gray-700
										  bg-white bg-clip-padding
										  border border-solid border-gray-300
										  rounded
										  transition
										  ease-in-out
										  m-0
										  focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none mb-2 "
		id="edit_product_name"
		placeholder="Name"
		bind:value={product_name}
	/>

	<textarea
		class="form-control
										block
										w-full
										px-3
										py-1.5
										text-base
										font-normal
										text-gray-700
										bg-white bg-clip-padding
										border border-solid border-gray-300
										rounded
										transition
										ease-in-out
										m-0
										focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none mb-2"
		id="edit_product_description"
		placeholder="Description"
		rows="4"
		bind:value={product_description}
	/>

	<Edit_Product_Ranking bind:product_ranking />

	<Edit_Price bind:product_price/>
</div>
