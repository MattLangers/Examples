<script lang="ts">
    import { text } from "svelte/internal";
    import "../app.css";
    import { onMount } from "svelte";
    import type { Product } from '../models/product'

    const endpoint = "https://localhost:7003/products";

    let products: Product[] = [];

    onMount(async function () {
        const response = await fetch(endpoint);
        const data = await response.json();
        products = data;
    });
</script>


<header class="bg-white text-black p-3 border border-solid border-gray-100">
    <div class="flex justify-between items-center p-3">
        <div>
            <a href="/" class="font-black font-weight: 900" alt="Matthew Langley: product catalogue">
                ML
            </a>
        </div>
        <div>
            <input type="text" name="product_search" id="product_search" value="" placeholder="search product catalogue" class="form-control relative flex-auto min-w-0 block w-full px-3 py-1.5 text-base font-normal text-gray-700 bg-white bg-clip-padding border border-solid border-gray-300 rounded transition ease-in-out m-0 focus:text-gray-700 focus:bg-white focus:border-blue-600 focus:outline-none">
        </div>
        <div>
            <nav class="min-w-full">
                <a href="/" class="pr-2">API docs</a>
                <a href="https://github.com/MattLangers/Portfolio" class="pr-2" target="_blank">
                    <svg viewBox="0 0 20 20" class="w-8 h-8 fill-current inline">
                        <path xmlns="http://www.w3.org/2000/svg" d="M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.013 8.013 0 0016 8c0-4.42-3.58-8-8-8z" />
                    </svg>
                </a>
            </nav>
        </div>
    </div>
</header>

<div class="w-full flex flex-col sm:flex-row flex-wrap sm:flex-nowrap py-4 flex-grow">
    <!-- fixed-width -->
    <div class="w-fixed w-full flex-shrink flex-grow-0 px-4">
        <div class="sticky top-0 p-4 w-full h-full">
            <!-- left -->
        </div>
    </div>
    <main class="w-full flex-grow px-3">
        {#each products as product}
            <div class="p-2">
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
        {/each}
    </main>
    <div class="w-fixed w-full flex-shrink flex-grow-0 px-2">
        <!-- fixed-width -->
        <div class="flex sm:flex-col px-2">
            <!-- right -->
        </div>
    </div>
</div>
<footer class="bg-white mt-auto">
    
</footer>