# Tailwind CSS Usage Guide

This site now includes **Tailwind CSS v4.1.18** alongside the original custom styles.

## Quick Start

### Building CSS

```bash
# Install dependencies
npm install

# Build CSS once
npm run build:css

# Watch for changes and rebuild automatically
npm run watch:css
```

## Using Tailwind Utilities

You can now use any Tailwind utility class in your HTML files. The utilities work alongside the existing custom CSS.

### Example: Responsive Grid Layout

```html
<div class="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-3 gap-4">
  <div class="p-4 bg-blue-100 rounded-lg">Item 1</div>
  <div class="p-4 bg-blue-100 rounded-lg">Item 2</div>
  <div class="p-4 bg-blue-100 rounded-lg">Item 3</div>
</div>
```

### Example: Flexbox Layout

```html
<div class="flex items-center justify-between p-4">
  <h2 class="text-2xl font-bold">Title</h2>
  <button class="px-4 py-2 bg-blue-500 text-white rounded hover:bg-blue-600">
    Click Me
  </button>
</div>
```

### Example: Spacing and Typography

```html
<article class="max-w-4xl mx-auto px-4 py-8">
  <h1 class="text-4xl font-bold mb-4">Heading</h1>
  <p class="text-lg text-gray-700 leading-relaxed">
    This is a paragraph with Tailwind typography utilities.
  </p>
</article>
```

## Tailwind v4 Features

Tailwind CSS v4 introduces several improvements:

- **CSS-first configuration**: No JavaScript config file needed
- **Faster builds**: Optimized compilation engine
- **Better performance**: Smaller output file sizes
- **Modern CSS**: Uses native CSS features like `@layer`

## Style Priority

When there are conflicts between Tailwind utilities and custom CSS:

1. Custom CSS rules (from `src/css/base.css`) are loaded after Tailwind
2. Inline styles and `!important` declarations take highest priority
3. Use Tailwind's `!` prefix for important utilities: `!text-red-500`

## Resources

- [Tailwind CSS Documentation](https://tailwindcss.com)
- [Tailwind v4 Announcement](https://tailwindcss.com/blog/tailwindcss-v4)
- [Utility-First CSS](https://tailwindcss.com/docs/utility-first)

## File Structure

```
awolf.github.io/
├── src/
│   └── css/
│       ├── input.css      # Source file that imports Tailwind and base styles
│       └── base.css       # Original custom styles
├── css/
│   └── style.css          # Compiled output (Tailwind + custom styles)
├── package.json           # Node dependencies and build scripts
└── README.md              # Project documentation
```

## Updating Tailwind

To update to a newer version of Tailwind CSS:

```bash
npm update tailwindcss @tailwindcss/cli
npm run build:css
```

Check the [Tailwind changelog](https://github.com/tailwindlabs/tailwindcss/releases) for any breaking changes before updating.
