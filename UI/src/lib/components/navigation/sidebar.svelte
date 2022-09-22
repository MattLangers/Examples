<script lang="ts">
	import { onMount } from 'svelte';
	export let open = false;
	import { NavigationHelper } from './helpers/navigationHelper';

	let currentPath = "";
	onMount(() => {
		currentPath = window.location.pathname;
	});

	let navs = new NavigationHelper().navigation;
</script>

<aside class="absolute h-full bg-white border-r-2 shadow-lg" class:open>
	<nav class="divide-y divide-slate-900/10 text-base leading-7 text-slate-900">
		<div class="py-6 px-8">
			<h3>Navigation</h3>
		</div>
		{#each navs as navigation}
			<div class="py-6 px-8 {currentPath === navigation.href ? 'bg-green-400 text-white' : ''}">
				<div class="-my-2 items-start space-y-2">
					<a href={navigation.href} class="block {navigation.class_name_for_tests}">{navigation.name}</a>
				</div>
			</div>
		{/each}
	</nav>
</aside>

<style>
	aside {
		right: 100%;
		transition: left 0.3s ease-in-out;
		height: 100%;
	}

	.open {
		right: 0;
	}
</style>
