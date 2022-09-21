<script lang="ts">
	import { NavigationHelper } from "$lib/components/navigation/helpers/navigationHelper"
	import { NavigationImageHelper } from "$lib/components/navigation/helpers/navigationImageHelper"
	import { each } from "svelte/internal";
	import { NavigationImageEnum, NavigationTypeEnum } from "$lib/models/navigation/navigationEnums";
	   
    const navigationImageHelper = new NavigationImageHelper();
    let navs = new NavigationHelper().navigation.filter(n => n.type == NavigationTypeEnum.Left);
</script>

<div class="top-0 h-full">
    <div>
        <!-- TODO: identify which page you are on by adding these css classes bg-green-400 text-white -->
        {#each navs as navigation}
            <div class="flex items-center rounded-md p-1.5">
                <svelte:component this={navigationImageHelper.GiveMeImage(navigation.image)} />
                <span>{navigation.name}</span>
            </div>
        {/each}
    </div>
</div>