import { expect, test } from '@playwright/test';

test("index page: initial page load product count", async ({ page }) => {
	await page.goto('/');
	
	await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("/products")
		)
	]);

	expect(Number(await page.textContent('id=product-count'))).toBeGreaterThan(0);
});