import type { NavigationImageEnum, NavigationTypeEnum } from "./navigationEnums"

export type Navigation = {
	name: string
	href: string
    type: NavigationTypeEnum
	image: NavigationImageEnum
	class_name_for_tests: string 
}