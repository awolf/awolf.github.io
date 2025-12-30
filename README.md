# Adam J Wolf Blog
My personal website source using CodeKit as a preprocessor. It's all manual folks.

## Tailwind CSS Setup

This site now uses Tailwind CSS v4 for styling. The original custom styles are preserved and work alongside Tailwind utilities.

### Prerequisites

- Node.js (v20 or later)
- npm

### Installation

```bash
npm install
```

### Building CSS

To build the CSS file:

```bash
npm run build:css
```

To watch for changes and rebuild automatically:

```bash
npm run watch:css
```

### How it Works

- Source CSS is in `src/css/input.css`
- This file imports Tailwind CSS and the original `css/style.css`
- The build process compiles everything into `css/style.css`
- All HTML files reference `css/style.css` which now includes Tailwind utilities

### Using Tailwind

You can now use Tailwind utility classes in your HTML files alongside the existing custom CSS. For example:

```html
<div class="flex items-center justify-center p-4 text-blue-500">
  Content here
</div>
```

The original custom styles remain intact and take precedence where there are conflicts.

## To Do Writing 

- [ ] Technology Side Effects
    - Read: boringtechnology.club
    - Read: dotclub.club
- [ ] Maybe Bloomfilters
- [ ] Reducing Complexity
    https://itnext.io/the-origin-of-complexity-8ecb39130fc
    http://curtclifton.net/papers/MoseleyMarks06a.pdf
- [ ] PWL: The Tail at Scale

Distributed architecture concepts I learned while building a large payments system
https://blog.pragmaticengineer.com/distributed-architecture-concepts-i-have-learned-while-building-payments-systems/

Amazon Has a Secret Weapon Known as "Working Backwards"--and It Will Transform the Way You Work
https://www.inc.com/justin-bariso/amazon-uses-a-secret-process-for-launching-new-ideas-and-it-can-transform-way-you-work.html?cid=sf01001

Steve Smith: Continuous delivery and the Theory of Constraints
https://vimeo.com/370035221

Code less, engineer more
https://increment.com/teams/code-less-engineer-more/

The Service Mesh: What Every Software Engineer Needs to Know about the World's Most Over-Hyped Technology
https://servicemesh.io/
