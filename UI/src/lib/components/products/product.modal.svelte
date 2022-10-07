<script lang="ts">
    import type { Product } from '$lib/models/product';

    export let product: Product;
    export let openModal: boolean = false;
</script>

{#if openModal}
<div class="modal" id="my-modal-2">
    <div class="modal-box">
        <h3 class="font-bold text-lg">{product.name}</h3>
        <p class="py-4">
            You've been selected for a chance to get one year of subscription to use Wikipedia for
            free!
        </p>
        <div class="modal-action">
            <a href="/#" class="btn">Yay!</a>
        </div>
    </div>
</div>
{/if}