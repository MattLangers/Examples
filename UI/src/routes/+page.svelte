<script lang="ts">
    import "../app.css";
    import { onMount } from "svelte";
    import type { Product } from '../models/product'
	import type { ProductType } from "src/models/productType";
	import type { QueryStringParams } from "src/models/query.string.params";
	import { each } from "svelte/internal";

    const apiUrl = "https://localhost:7003/products";

    let products: Product[] = [];
    let productTypes: ProductType[] = [];
    let productTypeSelected: ProductType;
    let searchText: string = "";

    var getProducts = async function (productType?: ProductType, searchText?: string): Promise<void> {
        
        const querystringParameters: QueryStringParams = {};

        if(searchText !== undefined){
            querystringParameters.name = searchText;
        }

        if(productType !== undefined && productType.id !== undefined){
            querystringParameters["product-type"] = productType.id;
        }
        
        let url = (
            apiUrl + '?' +
            new URLSearchParams(querystringParameters).toString()
        );
        
        const response = await fetch(url);
        products = await response.json();
    }

    var getProductTypes = async function (): Promise<void> {
        
        const response = await fetch('https://localhost:7003/product-types');
        const data = await response.json();
        productTypes = data;
    }

    onMount(() => { getProducts(), getProductTypes()});
</script>

<header class="bg-white text-black p-3 border border-solid border-gray-100">
    <div class="flex justify-between items-center p-3">
        <div>
            <a href="/" class="font-black font-weight: 900" alt="Matthew Langley: product catalogue">
                ML
            </a>
        </div>
        <div class="flex items-center">   
            <label for="simple-search" class="sr-only">Search</label>
            <div class="relative w-full">
                <div class="flex absolute inset-y-0 left-0 items-center pl-3 pointer-events-none">
                    <svg aria-hidden="true" class="w-5 h-5 text-gray-500 dark:text-gray-400" fill="currentColor" viewBox="0 0 20 20" xmlns="http://www.w3.org/2000/svg"><path fill-rule="evenodd" d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z" clip-rule="evenodd"></path></svg>
                </div>
                <input 
                    bind:value="{searchText}"
                    type="text" 
                    id="simple-search" 
                    class="bg-gray-50 
                            border border-gray-300 
                            text-gray-900 
                            text-sm 
                            rounded-lg 
                            focus:ring-blue-500 
                            focus:border-blue-500 
                            block w-full 
                            pl-10 p-2.5 
                            dark:bg-white-700 
                            dark:border-gray-300 
                            dark:placeholder-gray-400 
                            dark:text-gray 
                            dark:focus:ring-blue-500 
                            dark:focus:border-blue-500" 
                    placeholder="Search" required>
            </div>
            <select 
                    id="product-type"
                    class="form-select 
                            appearance-none
                            bg-gray-50
                            block
                            px-4
                            py-2
                            text-base
                            font-normal
                            text-gray-700
                            bg-white bg-clip-padding bg-no-repeat
                            border border-gray-300
                            rounded-lg
                            transition
                            ease-in-out
                            ml-2
                            focus:text-gray-700 
                            focus:bg-white 
                            focus:border-blue-600 
                            focus:outline-none" 
                    aria-label="Product types"
                    bind:value={productTypeSelected}>
                    <option selected>Product type</option>
                    {#each productTypes as productType}
                        <option value="{productType}">{productType.name}</option>
                    {/each}
            </select>
            <button type="submit" 
                    on:click={() => { getProducts(productTypeSelected, searchText)}}
                    class="p-2.5 ml-2 
                            text-sm font-medium 
                            text-white bg-gray-700 
                            rounded-lg border 
                            border-gray-700 
                            hover:bg-gray-800 
                            focus:ring-4 
                            focus:outline-none 
                            focus:ring-gray-300 
                            dark:bg-gray-500 
                            dark:hover:bg-gray-600 
                            dark:focus:ring-gray-700">
                <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path></svg>
                <span class="sr-only">Search</span>
            </button>
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
        <div class="sticky top-0 w-full h-full">
            <div class="">
                <div class="flex items-center rounded-md p-1.5 bg-green-400 text-white">
                    <svg aria-hidden="true" class="mr-2.5 h-5 w-5 flex-none stroke-white" fill="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path fill-rule="evenodd" d="M8 4a4 4 0 100 8 4 4 0 000-8zM2 8a6 6 0 1110.89 3.476l4.817 4.817a1 1 0 01-1.414 1.414l-4.816-4.816A6 6 0 012 8z" clip-rule="evenodd"></path></svg>
                    View/Search products
                </div>
                <div class="flex items-center rounded-md p-1.5">
                    <svg class="mr-2.5 h-5 w-5 flex-none stroke-slate-400" fill="none" viewBox="0 0 24 24" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"><path d="M9 13h6m-3-3v6m5 5H7a2 2 0 01-2-2V5a2 2 0 012-2h5.586a1 1 0 01.707.293l5.414 5.414a1 1 0 01.293.707V19a2 2 0 01-2 2z"></path></svg>
                    Create new product
                </div>
            </div>
        </div>
    </div>
    <main class="w-full flex-grow px-3">
        <span>Product count: <span id="product-count">{products.length}</span></span>
        {#each products as product}
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