import { expect, test } from '@playwright/test';

test("index page: search by Bubblegum product type", async ({ page }) => {
	await page.goto('/');

	await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("product-type=")
		),
		await page.locator('id=product-type').selectOption({"label": "BubbleGum"}),
		await page.locator('button:has-text("Search")').click(),
	]);
	
	expect(Number(await page.textContent('id=product-count'))).toEqual(0);
});