import { createAction } from '@reduxjs/toolkit';

const fetchAppConfigAsync = createAction(
  'app/fetchAppConfigAsync',
  ({ callback = () => {}, showLoading = true } = {}) => ({
    payload: { callback, showLoading },
  }),
);

const setAppConfig = createAction('app/setAppConfig');

const setLanguageAsync = createAction('app/setLanguageAsync');

const logoutAsync = createAction(
  'app/logoutAsync',
  ({ client_id = '', token = '', refresh_token = '' } = {}) => ({
    payload: { client_id, token, refresh_token },
  }),
);

export default {
  fetchAppConfigAsync,
  setAppConfig,
  setLanguageAsync,
  logoutAsync,
};
