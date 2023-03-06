import '@styles/globals.css';
import 'tailwindcss/tailwind.css';
import React, { FC } from 'react';
import { AppProps } from 'next/app';

const MyApp: FC<AppProps> = ({ Component, pageProps }: AppProps) => (
  <Component {...pageProps} />
);
export default MyApp;