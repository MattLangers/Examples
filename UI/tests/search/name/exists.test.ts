import { expect, test } from '@playwright/test';

test("index page: search name does exist", async ({ page }) => {
	await page.goto('/');

	await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("https://localhost:7003/products?name=")
		),
		await page.locator('[placeholder="Search"]').fill('dolly'),
		await page.locator('button:has-text("Search")').click(),
	]);
	
	expect(Number(await page.textContent('id=product-count'))).toEqual(1);
});