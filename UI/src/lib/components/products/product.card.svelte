<script lang="ts">
	import type { Product } from '$lib/models/product';
	import ProductTypeIconComponent from '$lib/components/products/product.type.icon.svelte';
	import ProductModal from '$lib/components/products/product.modal.svelte';

    export let product: Product;

	let showModal = false;

	const handleToggleModal = () => {
		showModal = !showModal;
	};
</script>

<div class="w-full max-w-sm px-4 py-3 bg-white rounded-md shadow-md">
	<div class="flex items-center justify-between">
		<h1 class="mt-2 text-lg font-semibold text-gray-800">{product.name}</h1>
		<ProductTypeIconComponent productType={product.productType} />
	</div>

	<div>
		<p class="mt-2 text-sm text-gray-600">
			Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique
			exercitationem optio libero vitae accusamus cupiditate laborum eos.
		</p>
	</div>

	<div>
		<div class="flex mt-2 item-center">
			<svg class="w-5 h-5 text-amber-300 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-amber-300 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-amber-300 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-gray-300 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-gray-300 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>
		</div>
	</div>

	<div class="flex justify-between mt-3 item-center">
		<div class="flex flex-row w-full">
			<div class="basis-3/5">
				<h1 class="text-lg font-bold text-gray-700">£1.00</h1>
			</div>
			<div class="basis-1/5 icon_alignment" title="Click here to edit this product">
				<svg
					xmlns="http://www.w3.org/2000/svg"
					fill="none"
					viewBox="0 0 24 24"
					stroke-width="1.5"
					stroke="currentColor"
					class="w-6 h-6"
				>
					<path
						stroke-linecap="round"
						stroke-linejoin="round"
						d="M16.862 4.487l1.687-1.688a1.875 1.875 0 112.652 2.652L10.582 16.07a4.5 4.5 0 01-1.897 1.13L6 18l.8-2.685a4.5 4.5 0 011.13-1.897l8.932-8.931zm0 0L19.5 7.125M18 14v4.75A2.25 2.25 0 0115.75 21H5.25A2.25 2.25 0 013 18.75V8.25A2.25 2.25 0 015.25 6H10"
					/>
				</svg>
			</div>
			<div class="basis-1/5 icon_alignment cursor-pointer" title="Click here to archive this product" on:click={() => handleToggleModal()}>
				<svg
					xmlns="http://www.w3.org/2000/svg"
					fill="none"
					viewBox="0 0 24 24"
					stroke-width="1.5"
					stroke="currentColor"
					class="w-6 h-6"
				>
					<path
						stroke-linecap="round"
						stroke-linejoin="round"
						d="M20.25 7.5l-.625 10.632a2.25 2.25 0 01-2.247 2.118H6.622a2.25 2.25 0 01-2.247-2.118L3.75 7.5m6 4.125l2.25 2.25m0 0l2.25 2.25M12 13.875l2.25-2.25M12 13.875l-2.25 2.25M3.375 7.5h17.25c.621 0 1.125-.504 1.125-1.125v-1.5c0-.621-.504-1.125-1.125-1.125H3.375c-.621 0-1.125.504-1.125 1.125v1.5c0 .621.504 1.125 1.125 1.125z"
					/>
				</svg>
			</div>
		</div>
	</div>
</div>

<ProductModal bind:product={product} open={showModal} on:close={() => handleToggleModal()} />

<style>
	.icon_alignment {
		display: flex;
		align-items: right;
		justify-content: right;
	}
</style>
