<script lang="ts">
	export let product_ranking: number;
</script>

<input
	type="range"
	id="cowbell"
	name="cowbell"
	min="0"
	max="5"
	bind:value={product_ranking}
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
