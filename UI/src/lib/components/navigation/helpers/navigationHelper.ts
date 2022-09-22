import type { Navigation } from "$lib/models/navigation/navigation";
import { NavigationImageEnum, NavigationTypeEnum } from "$lib/models/navigation/navigationEnums";
import { variables } from "../../../../variables";

export interface INavigationHelper{
    navigation: Navigation[]
}

export class NavigationHelper implements INavigationHelper{

    public navigation: Navigation[] = [
        { name: "API docs", href: variables.api_URL + "/swagger/index.html", type: NavigationTypeEnum.TopRight, image: NavigationImageEnum.None },
        { name: "GitHub", href: "https://github.com/MattLangers/Portfolio", type: NavigationTypeEnum.TopRight, image: NavigationImageEnum.Github },
        { name: "View/Search products", href: "/", type: NavigationTypeEnum.Left, image: NavigationImageEnum.Create },
        { name: "Create new product", href: "/create", type: NavigationTypeEnum.Left, image: NavigationImageEnum.Search },
    ]
}