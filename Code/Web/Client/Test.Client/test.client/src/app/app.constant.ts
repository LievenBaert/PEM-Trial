import { CoreConfig } from '@arcelormittal-platform/core';
import { SecurityConfig } from '@arcelormittal-platform/security';
import { UiConfig } from '@arcelormittal-platform/UI';
import _config from 'xml-loader?explicitArray=false!../config/config.xml';

// tslint:disable-next-line:no-empty-interface
export interface AppConfig extends CoreConfig, SecurityConfig, UiConfig {}

export function buildAppConstants(): AppConfig {
  if(_config.default){
    return _config.default;
  }
  return _config;
}
