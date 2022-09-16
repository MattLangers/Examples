import { expect, test } from '@playwright/test';


test("index page: search name does not exist", async ({ page }) => {
	await page.goto('/');

	const [response] = await Promise.all([
		page.waitForResponse(
			response => 
				response.status() == 200 
				&& response.url().includes("/products?name=")
		),
		await page.locator('[placeholder="Search"]').fill('does not exist'),
		await page.locator('button:has-text("Search")').click(),
	]);

	console.log(await response.json());

	expect(Number(await page.textContent('id=product-count'))).toEqual(0);
});

