<script lang="ts">
	import type { Product } from "$lib/models/product";

	export let product: Product;
</script>

<div class="p-2 product-shell">
    <div class="block p-6 rounded-lg shadow-lg bg-white max-w-sm">
        <h5 class="text-gray-900 text-xl leading-tight font-medium mb-2">{product.name}</h5>
        <p class="text-gray-700 text-base mb-4">
            Product type: {product.productType.name}
        </p>
        <p class="text-gray-700 text-base">
            Product id: {product.id}
        </p>
    </div>
</div>