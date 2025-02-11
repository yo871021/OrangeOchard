import { definePreset } from '@primeng/themes';
import Aura from '@primeng/themes/aura';

const Preset = definePreset(Aura, {
  semantic: {
    primary: {
      50: '{orange.50}',
      100: '{orange.100}',
      200: '{orange.200}',
      300: '{orange.300}',
      400: '{orange.400}',
      500: '{orange.500}',
      600: '{orange.600}',
      700: '{orange.700}',
      800: '{orange.800}',
      900: '{orange.900}',
      950: '{orange.950}'
    }
    // colorScheme: {
    //   light: {
    //     primary: {
    //       color: '{orange.950}',
    //       inverseColor: '#ffffff',
    //       hoverColor: '{orange.900}',
    //       activeColor: '{orange.800}'
    //     },
    //     highlight: {
    //       background: '{orange.950}',
    //       focusBackground: '{orange.700}',
    //       color: '#ffffff',
    //       focusColor: '#ffffff'
    //     }
    //   }
    // }
  }
});

export default Preset;