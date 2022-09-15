import { expect, test } from '@playwright/test';

test("index page: search by product type - boiled", async ({ page }) => {
	await page.goto('/');
	
	await page.locator('id=product-type').selectOption('1');
  
  	await page.locator('button:has-text("Search")').click();
	
	expect(Number(await page.textContent('id=product-count'))).toEqual(3);
});

test("index page: search by product type - BubbleGum", async ({ page }) => {
	await page.goto('/');
	
	await page.locator('id=product-type').selectOption('BubbleGum');
  
  	await page.locator('button:has-text("Search")').click();
	
	expect(Number(await page.textContent('id=product-count'))).toEqual(3);
});