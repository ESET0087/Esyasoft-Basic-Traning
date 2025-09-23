import React, { createContext, useContext, useState } from 'react';

const ThemeContext = createContext();

export const useTheme = () => {
  return useContext(ThemeContext);
};

export const ThemeProvider = ({ children }) => {
  const [isDark, setIsDark] = useState(false);

  const toggleTheme = () => {
    setIsDark(prev => !prev);
  };

  return (
    <ThemeContext.Provider value={{
      toggleTheme,
      colors: {
        background: isDark ? '#000000' : '#ffffff',
        text: isDark ? '#ffffff' : '#000000',
      }
    }}>
      {children}
    </ThemeContext.Provider>
  );
};