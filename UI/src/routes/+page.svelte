<script lang="ts">
    import "../app.css";
    import type { Product } from "$lib/models/product"
	import ProductComponent from "$lib/components/products/product.card.svelte";
	import Footer from "$lib/components/footer/footer.svelte";
	import Logo from "$lib/components/header/logo.svelte";
	import LeftHandNavigation from "$lib/components/navigation/left.hand.nav.svelte";
	import Sidebar from "$lib/components/navigation/sidebar.svelte";
	import TopRightHandNav from "$lib/components/navigation/top.right.hand.nav.svelte";
	import Search from "$lib/components/search/search.svelte";
	import Loading from "$lib/components/search/loading.svelte";

    let products: Product[] = [];
    let searchProductsCompleted = false;
    let open = false;
</script>

<Sidebar bind:open/>

<header class="bg-white text-black p-3 border border-solid border-gray-100">
    <div class="flex justify-between items-center p-3">
        <Logo></Logo>
        <div class="flex items-center fade_in_search_area">   
            <Search bind:products bind:searchProductsCompleted/>
        </div>
        <div>
            <TopRightHandNav bind:sidebar={open}/>
        </div>
    </div>
</header>

<div class="flex">
    <div class="w-15 pt-2.5 hide_on_small_screens">
        <LeftHandNavigation></LeftHandNavigation>
    </div>
    <div class="grow h-14 pr-10">
        {#if searchProductsCompleted}
            <div class="grid grid-cols-2 md:grid-cols-3 gap-3 mt-2.5">
                {#each products as product}
                    <ProductComponent product={product}></ProductComponent>
                {/each}
            </div>
        {:else}
            <Loading />
        {/if}
    </div>
  </div>

<Footer></Footer>
