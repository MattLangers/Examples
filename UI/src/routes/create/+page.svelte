<script lang="ts">
    import "../../app.css";
    import type { Product } from "$lib/models/product"
	import Footer from "$lib/components/footer/footer.svelte";
	import Logo from "$lib/components/header/logo.svelte";
	import LeftHandNavigation from "$lib/components/navigation/left.hand.nav.svelte";
	import Sidebar from "$lib/components/navigation/sidebar.svelte";
	import TopRightHandNav from "$lib/components/navigation/top.right.hand.nav.svelte";
    import CreateProduct from "$lib/components/products/create/create.product.svelte"

    let open = false;
</script>

<Sidebar bind:open/>

<header class="bg-white text-black p-3 border border-solid border-gray-100">
    <div class="flex justify-between items-center p-3">
        <Logo></Logo>
        <div>   
            <p class="text-xl font-bold">Create product</p>
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
        <CreateProduct />
    </div>
  </div>

<Footer></Footer>
