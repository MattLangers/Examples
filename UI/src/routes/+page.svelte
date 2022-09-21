<script lang="ts">
    import "../app.css";
    import type { Product } from "$lib/models/product"
	import ProductComponent from "$lib/components/products/product.svelte";
	import Footer from "$lib/components/footer/footer.svelte";
	import Logo from "$lib/components/header/logo.svelte";
	import LeftHandNavigation from "$lib/components/navigation/left.hand.nav.svelte";
	import Sidebar from "$lib/components/navigation/sidebar.svelte";
	import TopRightHandNav from "$lib/components/navigation/top.right.hand.nav.svelte";
	import Search from "$lib/components/search/search.svelte";
	import Loader from "$lib/components/search/loader.svelte";

    let products: Product[] = [];
    let open = false;
</script>

<Sidebar bind:open/>

<header class="bg-white text-black p-3 border border-solid border-gray-100">
    <div class="flex justify-between items-center p-3">
        <Logo></Logo>
        <div class="flex items-center">   
            <Search bind:products/>
        </div>
        <div>
            <TopRightHandNav bind:sidebar={open}/>
        </div>
    </div>
</header>

<div class="w-full flex flex-col sm:flex-row flex-wrap sm:flex-nowrap py-4 flex-grow">
    <!-- fixed-width -->
    <div class="w-fixed w-full flex-shrink flex-grow-0 px-4">
        <LeftHandNavigation></LeftHandNavigation>
    </div>
    <main class="w-full flex-grow px-3">
        <div class="grid grid-cols-2 gap-3">
            {#each products as product}
                <ProductComponent product={product}></ProductComponent>
            {:else}
                <Loader />
            {/each}
        </div>
    </main>
    <div class="w-fixed w-full flex-shrink flex-grow-0 px-2">
        <!-- fixed-width -->
        <div class="flex sm:flex-col px-2">
            <!-- right -->
        </div>
    </div>
</div>
<Footer></Footer>