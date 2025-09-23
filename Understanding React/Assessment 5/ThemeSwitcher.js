import { useTheme } from './ThemeContext';

const ThemeSwitcher = () => {
  const { colors, toggleTheme } = useTheme();

  return (
    <div style={{ 
      backgroundColor: colors.background,
      color: colors.text,
      minHeight: '100vh',
      padding: '20px',
    }}>
      <h1>Hello Students!</h1>
      
      <button 
        onClick={toggleTheme}
        style={{
          padding: '10px 20px',
          marginTop: '20px',
          backgroundColor: colors.text,
          color: colors.background,
          border: 'none',
          borderRadius: '5px',
        }}
      >
        Toggle Theme
      </button>
    </div>
  );
};

export default ThemeSwitcher;