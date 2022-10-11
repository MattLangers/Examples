<script lang="ts">
	export let productName: string;
	export let productDescription: string;
	export let productPrice: number;
	export let productRanking: number;
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
		bind:value={productName}
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
		bind:value={productDescription}
	/>

	<input
		type="range"
		id="cowbell"
		name="cowbell"
		min="0"
		max="5"
		bind:value={productRanking}
		step="1"
		list="product_ranking_labels"
	/>

	<datalist id="product_ranking_labels">
		<option value="0" label="0" />
		<option value="1" label="1" />
		<option value="2" label="2" />
		<option value="3" label="3" />
		<option value="4" label="4" />
		<option value="5" label="5" />
	</datalist>

	<input
		type="number"
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
		id="edit_product_price"
		placeholder="Price"
		bind:value={productPrice}
	/>
</div>

<style>
	datalist {
		display: flex;
		flex-direction: column;
		justify-content: space-between;
		writing-mode: vertical-lr;
		width: 200px;
	}

	option {
		padding: 0;
	}

	input[type='range'] {
		width: 200px;
		margin: 0;
	}
</style>
