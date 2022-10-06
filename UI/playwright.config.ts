import type { PlaywrightTestConfig } from '@playwright/test';
import dotenv from 'dotenv';

dotenv.config({ path: '.env.development' });


const config: PlaywrightTestConfig = {
	webServer: {
		command: 'npm run build && npm run preview',
		port: 4173
	},
	use: {
		baseURL: process.env.PLAYWRIGHT_BASE_URL,
	},
	reporter: process.env.CI ? 'html' : 'list',
};

export default config;
