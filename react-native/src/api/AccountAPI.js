import api from './API';
import { getEnvVars } from '../../Environment';

const { oAuthConfig } = getEnvVars();

getLoginData = (username, password) => {
  const formData = {
    grant_type: 'password',
    scope: oAuthConfig.scope,
    username: username,
    password: password,
    client_id: oAuthConfig.clientId,
  };

  if (oAuthConfig.clientSecret)
    formData['client_secret'] = oAuthConfig.clientSecret;

  return Object.entries(formData)
    .map(([key, value]) => `${key}=${encodeURIComponent(value)}`)
    .join('&');
};

export const login = ({ username, password }) =>
  api({
    method: 'POST',
    url: '/connect/token',
    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    data: getLoginData(username, password),
    baseURL: oAuthConfig.issuer,
  }).then(({ data }) => data);

export const Logout = (
  input = { client_id: '', token: '', token_type_hint: '' },
) => {
  if (!input.token_type_hint) {
    input.token_type_hint = 'access_token';
  }

  const _data = Object.entries(input)
    .map(([key, value]) => `${key}=${encodeURIComponent(value)}`)
    .join('&');

  return api({
    method: 'POST',
    url: '/connect/revocat',
    headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    data: _data,
    baseURL: oAuthConfig.issuer,
  }).then(({ data }) => data);
};

export const getTenant = tenantName =>
  api({
    method: 'GET',
    url: `/api/abp/multi-tenancy/tenants/by-name/${tenantName}`,
  }).then(({ data }) => data);

export const getTenantById = tenantId =>
  api({
    method: 'GET',
    url: `/api/abp/multi-tenancy/tenants/by-id/${tenantId}`,
  }).then(({ data }) => data);
