# Mouse Macro Update Log

## Modern UI Update (2025-02-20)

### Overview
Implemented a comprehensive UI modernization featuring custom controls, a consistent dark theme, and improved visual feedback. This update enhances the application's professional appearance and user experience.

### Detailed Changes

#### 1. Custom Controls
- **ModernButton**
  - Professional rounded corner design
  - Smooth hover and click animations
  - Consistent theme-based color transitions
  - Enhanced visual feedback

- **ModernTrackBar**
  - Custom slider implementation
  - Smooth drag operations
  - Real-time value updates
  - Theme-consistent appearance
  - Enhanced visual feedback

#### 2. Theme System
- Implemented consistent dark theme
- Professional color scheme
- Standardized control appearances
- Improved visual hierarchy
- Enhanced readability

#### 3. Layout Improvements
- Responsive design implementation
- Proper DPI scaling support
- Fluid transitions between states
- Optimized control spacing
- Professional window management

#### 4. Visual Feedback
- Real-time state indicators
- Clear mode status display
- Smooth value transitions
- Enhanced debug information presentation
- Professional system tray integration

### Technical Implementation
- Custom control inheritance from base Windows Forms controls
- Double-buffered rendering for smooth animations
- Standardized color management system
- Efficient state-based rendering
- Thread-safe UI updates

### User-Facing Changes
1. **Enhanced Visuals**:
   - Professional dark theme
   - Consistent control styling
   - Improved readability
   - Smooth animations

2. **Better Interaction**:
   - Responsive controls
   - Clear visual feedback
   - Intuitive state indicators
   - Professional polish

3. **System Integration**:
   - Modern system tray presence
   - Professional window management
   - Consistent branding
   - Enhanced status display

### Notes
- All visual improvements maintain high performance
- Custom controls ensure consistent behavior
- Theme system allows future customization
- Professional appearance in all states


## Settings Configuration System Update (2025-02-19)

### Overview
Implemented a comprehensive settings configuration system that persists all user preferences across sessions using JSON file storage. This update ensures all macro settings, key bindings, and UI preferences are automatically saved and restored.

### Detailed Changes

#### 1. Settings Storage System
- Added JSON-based configuration file
- Located in executable directory
- Automatic creation with defaults
- Real-time saving on changes

#### 2. Managed Settings
```csharp
// Jitter settings
JitterStrength = 3;        // Default
JitterEnabled = false;     // Toggled by mode switch
AlwaysJitterMode = false;  // Locks to jitter mode

// Recoil reduction settings
RecoilReductionStrength = 1;    // Default
RecoilReductionEnabled = false; // Toggled by mode switch
AlwaysRecoilReductionMode = false; // Locks to recoil mode

// Key bindings
MacroToggleKey = "Capital";  // Default
ModeSwitchKey = "Q";        // Default

// UI preferences
MinimizeToTray = false;    // Default
StartMinimized = false;    // Default
```

#### 3. Settings Manager Implementation
- Thread-safe settings access
- Automatic error recovery
- Default value fallbacks
- Real-time UI updates

#### 4. Mouse Button Support
- Added support for Mouse3-5 for both toggle and switch keys
- Protected LMB/RMB from being set as they're used for activation
- Proper saving of mouse button bindings
- Clear UI feedback for key settings

### User-Facing Changes

1. Persistent Settings:
   - All settings automatically saved
   - Settings restored on startup
   - No manual configuration needed
   - Immediate saving on changes

2. Key Binding Improvements:
   - Support for keyboard keys
   - Support for Mouse3 (middle button)
   - Support for Mouse4 (XButton1)
   - Support for Mouse5 (XButton2)
   - Protection against using LMB/RMB

3. UI Enhancements:
   - Real-time setting updates
   - Clear key binding display
   - Mode state persistence
   - Debug panel toggle state

### Technical Implementation
- Uses Newtonsoft.Json for serialization
- File-based persistence system
- Automatic error handling
- Thread-safe operations
- Real-time UI synchronization

### Notes
- Configuration file created automatically if missing
- Invalid settings fall back to defaults
- All UI states persist between sessions
- Administrator privileges required for file operations

## Mode Switching and Always Mode Update (2025-02-19)

### Overview
Added new mode switching functionality allowing users to toggle between Jitter and Recoil Reduction modes, along with Always Mode options for locking into a specific mode. This update provides more flexibility and control over macro behavior.

### Detailed Changes

#### 1. Mode Switching System
- Added macro switch key (Default: Q) to toggle between modes
- Independent strength controls for each mode
- Visual indicators for active mode
- Default values optimized for each mode:
  - Recoil Reduction: 1 (default)
  - Jitter: 3 (default)

#### 2. Always Mode Options
- Added "Always Jitter Mode" checkbox
- Added "Always Recoil Reduction Mode" checkbox
- Locks macro to selected mode
- Prevents mode switching while active
- Independent from macro toggle key

#### 3. UI Enhancements
```csharp
private void UpdateModeLabels()
{
    lblJitterActive.Text = jitterEnabled || alwaysJitterMode ? "[Active]" : "";
    lblRecoilReductionActive.Text = !jitterEnabled || alwaysRecoilReductionMode ? "[Active]" : "";
}
```

#### 4. State Management
- Enhanced state tracking for mode switching
- Added safety checks for always mode conflicts
- Improved debug information display
- Updated window title to reflect current mode

### User-Facing Changes

1. Mode Switching:
   - Press Q (default) to switch between modes
   - Active mode indicated in UI
   - Strength settings preserved per mode
   - Real-time mode switching

2. Always Mode:
   - Enable "Always Jitter Mode" to lock to jitter
   - Enable "Always Recoil Reduction Mode" to lock to recoil reduction
   - Prevents accidental mode switching
   - Quick access to preferred mode

3. Visual Feedback:
   - Active mode indicators
   - Updated window title
   - Enhanced debug information
   - Clear strength labels per mode

### Technical Implementation
- Separate strength tracking for each mode
- Mode-specific activation logic
- Enhanced state management system
- Improved UI responsiveness
- Thread-safe mode switching

### Notes
- Both modes still require LMB + RMB for activation
- Mode switch key can be customized
- Always modes persist between sessions
- Administrator privileges required

## Recoil Reducer Update (2025-02-19)

### Overview
Added a new recoil reducer mode as the default macro behavior, with the original jitter functionality now available as a toggleable option. This update provides users with more control over their mouse movement patterns.

### Detailed Changes

#### 1. New Recoil Reducer Mode
- Added a dedicated recoil pattern focusing on vertical movement
- Pattern designed for consistent downward compensation
- Uses the same strength slider as jitter mode
- Set as the default macro behavior

#### 2. Jitter Mode Toggle
- Added checkbox to enable/disable jitter mode
- Original jitter pattern preserved when enabled
- Seamless switching between modes
- Strength slider affects both modes proportionally

#### 3. Pattern Implementation
```csharp
// Recoil pattern (vertical movement only)
private readonly (int dx, int dy)[] recoilPattern = new[]
{
    (0, 7), (0, 7), (0, 6), (0, 7), (0, 7),
    (0, 6), (0, 7), (0, 7), (0, 6), (0, 7),
    (0, 6), (0, 7), (0, 7), (0, 6), (0, 7),
    (0, 7), (0, 6), (0, 7), (0, 7), (0, 6),
    (0, 7), (0, 7), (0, 6), (0, 7)
};
```

#### 4. UI Updates
- Added "Enable Jitter Mode" checkbox
- Updated window title to show current mode
- Enhanced debug information to display mode changes
- Maintained existing strength slider functionality
- Improved strength label to show current mode

### User-Facing Changes
1. Default Behavior:
   - Recoil reducer mode active by default
   - Vertical-only movement for consistent recoil control
   - Strength slider affects vertical movement intensity

2. Jitter Mode Option:
   - Can be enabled via checkbox
   - Restores original horizontal + vertical jitter pattern
   - Maintains same strength adjustment system

3. Mode Switching:
   - Real-time switching between modes
   - No need to toggle macro off/on when changing modes
   - Current mode displayed in window title and strength label

### Technical Implementation
- Separate pattern arrays for recoil and jitter modes
- Unified strength adjustment system
- Seamless pattern switching logic
- Enhanced debug information for mode changes
- Updated UI labels to reflect current mode

### Notes
- Both modes use the same activation method (LMB + RMB)
- Strength slider (1-20) affects both modes equally
- Mode selection persists between macro toggles
- Administrator privileges still required

## UI Improvements (2025-02-19)

### Enhanced Text Formatting
- Improved text formatting for better readability
- Implemented dedicated labels for values and prefixes
- Added bold styling for important values:
  - Current toggle key
  - Jitter strength
  - Recoil strength
- Removed complex Graphics-based text rendering in favor of native label controls

### Code Improvements
- Enhanced thread safety with proper InvokeRequired checks
- Improved code maintainability by separating label updates
- Standardized debug message handling
- Optimized performance by eliminating manual Graphics operations

### Technical Details
- Split labels into prefix and value components for better control
- Implemented dedicated update methods:
  - `UpdateCurrentKey(string key)`
  - `UpdateJitterStrength(int strength)`
  - `UpdateRecoilStrength(int strength)`
- Standardized debug message format across all updates
- Maintained consistent white text color with Segoe UI font

## Build System Update (2025-02-19)

### Overview
Added an automated build script (`build.bat`) to streamline the build process for both Debug and Release configurations. The script includes automatic administrator privilege elevation and comprehensive error handling.

### Build Script Features

#### 1. Automatic Admin Elevation
```batch
:: Auto-elevation mechanism
net session >nul 2>&1
if %errorLevel% == 0 (
    goto :admin
) else (
    echo Requesting administrative privileges...
    goto :UACPrompt
)
```
- Automatically detects if admin privileges are needed
- Requests elevation via UAC prompt if necessary
- Seamlessly continues execution after elevation

#### 2. Build Process Steps
1. **Solution Cleaning**
   - Runs `dotnet clean` to remove previous build artifacts
   - Manually removes `bin` and `obj` directories
   - Ensures clean build environment

2. **Package Restoration**
   - Executes `dotnet restore` to update dependencies
   - Verifies all required packages are available

3. **Dual Configuration Build**
   - Builds Debug configuration for development
   - Builds Release configuration for distribution
   - Maintains separate output directories for each

#### 3. Error Handling
- Checks return code after each critical operation
- Displays clear error messages on failure
- Pauses execution to show error details
- Prevents continuation if any step fails

### Usage Instructions
1. **Simple Execution**
   - Double-click `build.bat` in File Explorer
   - Script will automatically request admin rights if needed

2. **Command Line Usage**
   ```cmd
   build.bat
   ```
   - Can be run from any command prompt
   - No manual "Run as Administrator" needed

3. **Output Locations**
   - Debug: `bin\Debug\net6.0-windows\NotesTasks.exe`
   - Release: `bin\Release\net6.0-windows\NotesTasks.exe`

### Technical Implementation
- Uses native Windows batch scripting
- Leverages VBScript for UAC elevation
- Implements proper directory handling with `%~dp0`
- Maintains clean error handling with exit codes

## Mouse Button Toggle Support Update (2025-02-18)

### Overview
Added support for using mouse buttons (Mouse3, Mouse4, Mouse5) as toggle keys for the macro functionality. This enhancement allows users to use additional mouse buttons instead of being limited to keyboard keys only.

### Detailed Changes

#### 1. New Constants Added
- `WM_MBUTTONDOWN (0x0207)`: For middle mouse button detection
- `WM_XBUTTONDOWN (0x020B)`: For side mouse buttons detection
- `XBUTTON1 (0x0001)`: For Mouse4
- `XBUTTON2 (0x0002)`: For Mouse5

#### 2. New Toggle Type System
Added `ToggleType` enum to track the type of toggle being used:
```csharp
private enum ToggleType
{
    Keyboard,
    MouseMiddle,
    MouseX1,
    MouseX2
}
```

#### 3. Mouse Hook Enhancements
- Modified `MouseHookCallback` to handle middle click and X buttons
- Added safety checks to prevent LMB/RMB from being set as toggle keys
- Added helper methods:
  - `IsXButton1`: Checks if Mouse4 is pressed
  - `IsXButton2`: Checks if Mouse5 is pressed

#### 4. UI Updates
- Updated toggle key display to show mouse button names:
  - "Mouse3 (Middle)"
  - "Mouse4"
  - "Mouse5"
- Enhanced debug information to show mouse button toggle states

### User-Facing Changes
1. Users can now set the following as toggle keys:
   - Middle mouse button (Mouse3)
   - Forward side button (Mouse4)
   - Back side button (Mouse5)
   - Any keyboard key (maintained from previous version)

2. Left and Right mouse buttons remain reserved for macro activation
   - LMB + RMB combination activates the jitter
   - These buttons cannot be set as toggle keys

### Technical Implementation
- Uses Windows API's `mouseData` field to detect specific X buttons
- Implements bit manipulation to extract X button information
- Maintains separate toggle type tracking for proper event handling
- Preserves existing keyboard toggle functionality

### Notes
- Administrator privileges are still required for proper functionality
- System tray functionality remains unchanged
- Jitter strength adjustment works the same with all toggle types