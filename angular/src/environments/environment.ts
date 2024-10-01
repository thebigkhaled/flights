 import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44360/',
  redirectUri: baseUrl,
  clientId: 'flights_App',
  responseType: 'code',
  scope: 'offline_access flights',
  requireHttps: true,
};

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'flights',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44360',
      rootNamespace: 'flights',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
} as Environment;
