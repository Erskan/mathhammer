import { MathhammerAppPage } from './app.po';

describe('mathhammer-app App', () => {
  let page: MathhammerAppPage;

  beforeEach(() => {
    page = new MathhammerAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!');
  });
});
