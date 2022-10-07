<script lang="ts">
	import type { Product } from "$lib/models/product";

	export let product: Product;
</script>

<div class="w-full max-w-sm px-4 py-3 bg-white rounded-md shadow-md">
    <div class="flex items-center justify-between">
        <h1 class="mt-2 text-lg font-semibold text-gray-800">{product.name}</h1>
        <span class="px-3 py-1 text-xs text-blue-800 uppercase bg-red-200 rounded-full">{product.productType.name}</span>
    </div>

    <div>
        <p class="mt-2 text-sm text-gray-600">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Odio eligendi similique exercitationem optio libero vitae accusamus cupiditate laborum eos.</p>
    </div>

    <div>
        <div class="flex mt-2 item-center">
            <svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
                <path d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"></path>
            </svg>

            <svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
                <path d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"></path>
            </svg>

            <svg class="w-5 h-5 text-gray-700 fill-current" viewBox="0 0 24 24">
                <path d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"></path>
            </svg>

            <svg class="w-5 h-5 text-gray-300 fill-current" viewBox="0 0 24 24">
                <path d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"></path>
            </svg>

            <svg class="w-5 h-5 text-gray-300 fill-current" viewBox="0 0 24 24">
                <path d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"></path>
            </svg>
        </div>
    </div>

    <div class="flex justify-between mt-3 item-center">
        <h1 class="text-lg font-bold text-gray-700">£1.00</h1>
        <button class="px-4 py-2 font-semibold text-sm bg-cyan-500 text-white rounded-full shadow-sm">Edit</button>
    </div>
</div>