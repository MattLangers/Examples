<script lang="ts">
	import type { ProductType } from '$lib/models/productType';

	export let productType: ProductType;

	function getClass(id: number) {
		switch (id) {
			case 1: {
				return 'bg-red-600';
			}

			case 2: {
				return 'bg-orange-400';
			}

			case 3: {
				return 'bg-amber-400';
			}

			case 4: {
				return 'bg-yellow-300';
			}

			case 5: {
				return 'bg-lime-400';
			}

			case 6: {
				return 'bg-green-400';
			}

			case 7: {
				return 'bg-sky-400';
			}

			case 8: {
				return 'bg-blue-600';
			}

			case 9: {
				return 'bg-purple-400';
			}

			case 10: {
				return 'bg-pink-400';
			}

			case 11: {
				return 'bg-rose-900';
			}

			case 12: {
				return 'bg-slate-400';
			}

			default: {
				return 'bg-red-200';
			}
		}
	}
</script>

<span class="px-3 py-1 text-xs text-white font-bold uppercase rounded-full {getClass(productType.id)}"
	>{productType.name}</span
>
