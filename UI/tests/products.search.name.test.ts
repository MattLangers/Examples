import { expect, test } from '@playwright/test';

test("index page: search name dolly", async ({ page }) => {
	await page.goto('/');
	
	await page.locator('[placeholder="Search"]').click();
	
	await page.locator('[placeholder="Search"]').fill('dolly');
	
	await page.locator('button:has-text("Search")').click();
	
	const productsCount = Number(await page.textContent('id=product-count'));

	console.log(productsCount);

	page.waitForTimeout(20000);

	expect(productsCount).toEqual(1);
});

test("index page: search for product that doesn't exists", async ({ page }) => {
	await page.goto('/');
	
	await page.locator('[placeholder="Search"]').click();
	
	await page.locator('[placeholder="Search"]').fill('beans');
	
	await page.locator('button:has-text("Search")').click();
	
	const productsCount = Number(await page.textContent('id=product-count'));

	expect(productsCount).toEqual(0);
});