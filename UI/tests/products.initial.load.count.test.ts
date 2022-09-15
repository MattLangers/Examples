import { expect, test } from '@playwright/test';

test("index page: initial page load product count", async ({ page }) => {
	await page.goto('/');
	expect(Number(await page.textContent('id=product-count'))).toBeGreaterThanOrEqual(0);
});