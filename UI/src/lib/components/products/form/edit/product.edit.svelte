<script lang="ts">
	import type { Product } from '$lib/models/product';
	import { variables } from '$lib/../variables';
	import { createEventDispatcher } from 'svelte';
	import { products as productsStore } from '$lib/components/products/product.store';
	import { Product_Edit_Object_Builder as Product_Edit_Object_Builder } from './product.edit.object.builder';
	import type { Product_Edit as Product_Edit } from '$lib/models/product.edit';
	import Product_Form from './product.edit.form.svelte';

	export let open = false;
	export let product: Product;

	let product_name = product.name;
	let product_description = product.description;
	let product_price = product.price;
	let product_ranking = product.ranking;
	let product_edit: Product_Edit;
	let submit_button_disabled = false;

	productsStore.subscribe(() => {});

	const dispatch = createEventDispatcher();

	async function handleEdit() {
		if (product.id.length > 0) {
			submit_button_disabled = true;
			var result = await editProduct(product);
			if (result) {
				product.name = product_name;
				product.description = product_description;
				product.price = product_price;
				product.ranking = product_ranking;
				productsStore.update((contents) => [...contents, product]);
				dispatch('close');
				submit_button_disabled = false;
			}
		}
	}

	var editProduct = async function (product: Product): Promise<boolean> {
		product_edit = new Product_Edit_Object_Builder().create(product, {
			id: product.id,
			productType: product.productType,
			name: product_name,
			description: product_description,
			ranking: product_ranking,
			price: product_price
		});
		const response = await fetch(variables.api_URL + 'products/' + product.id, {
			method: 'PUT',
			headers: {
				'Content-Type': 'application/json'
			},
			body: JSON.stringify(product_edit)
		});

		await response;
		return response.ok;
	};
</script>

{#if open}
	<div class="relative z-20" aria-labelledby="modal-title" role="dialog" aria-modal="true">
		<div class="fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity" />

		<div class="fixed inset-0 z-10 overflow-y-auto">
			<div class="flex min-h-full items-end justify-center p-4 text-center sm:items-center sm:p-0">
				<div
					class="relative transform overflow-hidden rounded-lg bg-white text-left shadow-xl transition-all sm:my-8 sm:w-full sm:max-w-lg"
				>
					<div class="px-4 pt-5 pb-4 sm:p-6 sm:pb-4">
						<div class="sm:flex sm:items-start">
							<div
								class="mx-auto flex h-12 w-12 flex-shrink-0 items-center justify-center rounded-full bg-red-100 sm:mx-0 sm:h-10 sm:w-10"
							>
								<svg
									xmlns="http://www.w3.org/2000/svg"
									fill="none"
									viewBox="0 0 24 24"
									stroke-width="1.5"
									stroke="currentColor"
									class="w-6 h-6"
								>
									<path
										stroke-linecap="round"
										stroke-linejoin="round"
										d="M16.862 4.487l1.687-1.688a1.875 1.875 0 112.652 2.652L10.582 16.07a4.5 4.5 0 01-1.897 1.13L6 18l.8-2.685a4.5 4.5 0 011.13-1.897l8.932-8.931zm0 0L19.5 7.125M18 14v4.75A2.25 2.25 0 0115.75 21H5.25A2.25 2.25 0 013 18.75V8.25A2.25 2.25 0 015.25 6H10"
									/>
								</svg>
							</div>
							<div class="mt-3 text-center sm:mt-0 sm:ml-4 sm:text-left grow">
								<Product_Form bind:name={product_name} bind:description={product_description} bind:price={product_price} bind:ranking={product_ranking} />
							</div>
						</div>
					</div>
					<div class="bg-gray-50 px-4 py-3 sm:flex sm:flex-row-reverse sm:px-6">
						<button
							type="button"
							class="inline-flex w-full justify-center rounded-md border border-transparent bg-red-600 px-4 py-2 text-base font-medium text-white shadow-sm hover:bg-red-700 focus:outline-none focus:ring-2 focus:ring-red-500 focus:ring-offset-2 sm:ml-3 sm:w-auto sm:text-sm"
							id="product_edit_submit_button"
							on:click={handleEdit}
							disabled={submit_button_disabled}
						>
							<svg
								class="animate-spin -ml-1 mr-3 h-5 w-5 text-white {submit_button_disabled
									? ''
									: 'processing_edit_request'}"
								xmlns="http://www.w3.org/2000/svg"
								fill="none"
								viewBox="0 0 24 24"
							>
								<circle
									class="opacity-25"
									cx="12"
									cy="12"
									r="10"
									stroke="currentColor"
									stroke-width="4"
								/>
								<path
									class="opacity-75"
									fill="currentColor"
									d="M4 12a8 8 0 018-8V0C5.373 0 0 5.373 0 12h4zm2 5.291A7.962 7.962 0 014 12H0c0 3.042 1.135 5.824 3 7.938l3-2.647z"
								/>
							</svg>
							Submit
						</button>
						<button
							type="button"
							class="mt-3 inline-flex w-full justify-center rounded-md border border-gray-300 bg-white px-4 py-2 text-base font-medium text-gray-700 shadow-sm hover:bg-gray-50 focus:outline-none focus:ring-2 focus:ring-indigo-500 focus:ring-offset-2 sm:mt-0 sm:ml-3 sm:w-auto sm:text-sm"
							on:click={() => dispatch('close')}>Cancel</button
						>
					</div>
				</div>
			</div>
		</div>
	</div>
{/if}

<style>
	.processing_edit_request {
		visibility: hidden;
		display: none;
	}
</style>
