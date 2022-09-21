<script lang="ts">
	export let open = false
	import { NavigationHelper } from "./helpers/navigationHelper";
	import { NavigationImageHelper } from "$lib/components/navigation/helpers/navigationImageHelper"
	
	const navigationImageHelper = new NavigationImageHelper();
    let navs = new NavigationHelper().navigation
</script>

<aside class="absolute w-full h-full bg-gray-200 border-r-2 shadow-lg" class:open>
	<div class="grid grid-cols-2 p-10 w-20">
		{#each navs as navigation}
			<div class=""><svelte:component this={navigationImageHelper.GiveMeImage(navigation.image)} /></div>
			<div class=""><a href="{navigation.href}" class="block">{navigation.name}</a></div>
		{/each}
	</div>
</aside>

<style>
	aside {
		left: -100%;
		transition: left 0.3s ease-in-out;
		height: 100%;
	}
	
	.open {
		left: 0
	}
</style>