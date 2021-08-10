const colors = require('tailwindcss/colors');
module.exports = {
     purge: {
    enabled: true,
        content: [
            './**/*.html',
            './**/*.razor',
            './CodesDatabase.cs'
        ],
  },
  darkMode: false, // or 'media' or 'class'
  theme: {
      extend: {
          colors: {
              sky: colors.sky,
              fuchsia: colors.fuchsia,
          },
      },
  },
  variants: {
    extend: {},
  },
  plugins: [],
}
