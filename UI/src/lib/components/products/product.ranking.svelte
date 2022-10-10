<script lang="ts">
    export let ranking: number;


</script>

<div class="flex mt-2 item-center">
			<svg class="w-5 h-5 {(ranking > 0 ? 'text-amber-300' : 'text-gray-300')} fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 {(ranking > 1 ? 'text-amber-300' : 'text-gray-300')} fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 {(ranking > 2 ? 'text-amber-300' : 'text-gray-300')} fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 {(ranking > 3 ? 'text-amber-300' : 'text-gray-300')} fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>

			<svg class="w-5 h-5 {(ranking > 4 ? 'text-amber-300' : 'text-gray-300')} fill-current" viewBox="0 0 24 24">
				<path
					d="M12 17.27L18.18 21L16.54 13.97L22 9.24L14.81 8.63L12 2L9.19 8.63L2 9.24L7.46 13.97L5.82 21L12 17.27Z"
				/>
			</svg>
		</div>

