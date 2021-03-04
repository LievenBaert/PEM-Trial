import { environment } from './environment';

describe('Environment', () => {
  let env: any;

  beforeEach(() => {
    env = environment;
  });
  test('production should be false', () => {
    expect(env.production).toBe(false);
  });
});
