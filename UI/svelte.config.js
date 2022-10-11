import azure from 'svelte-adapter-azure-swa';
import preprocess from 'svelte-preprocess';

const config = {
	preprocess: preprocess({
		postcss: true,
	  }),

	kit: {
		adapter: azure()
	}
};

export default config;
