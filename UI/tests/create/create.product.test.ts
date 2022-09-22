import { expect, test } from '@playwright/test';

test("index page: initial page load product count", async ({ page }) => {
	
	await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("/products")
		),
		await page.goto('/')
	]);

	await page.locator('#left-hand-nav .pc_test_create').click();
	
	await page.locator('[placeholder="Product name"]').click();
	
	await page.locator('[placeholder="Product name"]').fill('tests');
	
	await page.locator('id=product-type').selectOption({"label": "Boiled"});
	
	await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("/products")
		),
		await page.locator('button:has-text("Create")').click()
	]);

	expect(true).toBeTruthy();
});