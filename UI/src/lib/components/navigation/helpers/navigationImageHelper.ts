import { NavigationImageEnum } from "$lib/models/navigation/navigationEnums";
import type { SvelteComponentTyped } from "svelte";
import Github from "../images/github.svelte";
import Create from "../images/create.svelte";
import Search from "../images/search.svelte";
import NoImageSvelte from "../images/no.image.svelte";

export interface INavigationImageHelper {
    GiveMeImage(imageType: NavigationImageEnum): ConstructorOfATypedSvelteComponent
}

export class NavigationImageHelper implements INavigationImageHelper {
    GiveMeImage(imageType: NavigationImageEnum): ConstructorOfATypedSvelteComponent {

        switch (imageType) {
            case NavigationImageEnum.Create:
                return Create;
            case NavigationImageEnum.Github:
                return Github;
            case NavigationImageEnum.Search:
                return Search;
            default:
                return NoImageSvelte;
        }
    }
}