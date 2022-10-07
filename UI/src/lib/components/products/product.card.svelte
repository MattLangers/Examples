<script lang="ts">
	import type { Product } from '$lib/models/product';
    import ProductTypeIconComponent from '$lib/components/products/product.type.icon.svelte'

	export let product: Product;
</script>

<div class="w-full max-w-sm px-4 py-3 bg-white rounded-md shadow-md">
	<div class="flex items-center justify-between">
		<h1 class="mt-2 text-lg font-semibold text-gray-800">{product.name}</h1>
		<ProductTypeIconComponent productType={product.productType}></ProductTypeIconComponent>
	</div>

	<div>
		<p class="mt-2 text-sm text-gray-600">
			Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique
			exercitationem optio libero vitae accusamus cupiditate laborum eos.
		</p>
	</div>

	<div>
		<div class="flex mt-2 item-center">
			<svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
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
			<div class="basis-1/5 icon_alignment">
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
			<div class="basis-1/5 icon_alignment">
				<svg
					xmlns="http://www.w3.org/2000/svg"
					fill="none"
					viewBox="0 0 24 24"
					stroke-width="1.5"
					stroke="currentColor"
					class="w-6 h-6"
				>
					<path stroke-linecap="round" stroke-linejoin="round" d="M6 18L18 6M6 6l12 12" />
				</svg>
			</div>
		</div>
	</div>
</div>

<style>
	.icon_alignment {
		display: flex;
		align-items: right;
		justify-content: right;
	}
</style>