<script lang="ts">
	import { NavigationHelper } from "$lib/components/navigation/helpers/navigationHelper"
	import { NavigationImageHelper } from "$lib/components/navigation/helpers/navigationImageHelper"
	import { each, onMount } from "svelte/internal";
	import { NavigationTypeEnum } from "$lib/models/navigation/navigationEnums";
	   
    const navigationImageHelper = new NavigationImageHelper();
    let navs = new NavigationHelper().navigation.filter(n => n.type == NavigationTypeEnum.Left);

    let currentPath = "";
    onMount(() => {
        currentPath = window.location.pathname;
    });
</script>

<div class="top-0 h-full">
    <div id="left-hand-nav">
        {#each navs as navigation}
            <div class="flex items-center rounded-md p-1.5 {currentPath === navigation.href ? 'bg-green-400 text-white' : ''}">
                <svelte:component this={navigationImageHelper.GiveMeImage(navigation.image)} />
                <a href="{navigation.href}" class="{navigation.class_name_for_tests}">{navigation.name}</a>
            </div>
        {/each}
    </div>
</div>