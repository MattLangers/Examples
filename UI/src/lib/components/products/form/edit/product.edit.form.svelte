<script lang="ts">
	import Description from '../elements/description/create.edit.description.svelte';
	import Price from '../elements/price/create.edit.price.svelte';
	import Ranking from '../elements/ranking/create.edit.product.ranking.svelte';

	export let name: string;
	export let description: string;
	export let price: number;
	export let ranking: number;
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
		bind:value={name}
	/>

	<Description bind:description={description} />

	<Ranking bind:ranking={ranking} />

	<Price bind:price={price} />
</div>
